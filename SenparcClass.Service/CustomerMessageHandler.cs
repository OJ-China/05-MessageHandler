using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.AppStore;
using Senparc.Weixin.MP.Entities;
using Senparc.Weixin.MP.Entities.Request;
using Senparc.Weixin.MP.MessageHandlers;

namespace SenparcClass.Service
{
    public class CustomerMessageHandler:MessageHandler<CustomMessageContext>
    {
        public CustomerMessageHandler(Stream inputStream, PostModel postModel = null, int maxRecordCount = 0, DeveloperInfo developerInfo = null) : base(inputStream, postModel, maxRecordCount, developerInfo)
        {
        }

        public CustomerMessageHandler(XDocument requestDocument, PostModel postModel = null, int maxRecordCount = 0, DeveloperInfo developerInfo = null) : base(requestDocument, postModel, maxRecordCount, developerInfo)
        {
        }

        public CustomerMessageHandler(RequestMessageBase requestMessageBase, PostModel postModel = null, int maxRecordCount = 0, DeveloperInfo developerInfo = null) : base(requestMessageBase, postModel, maxRecordCount, developerInfo)
        {
        }

        public override IResponseMessageBase DefaultResponseMessage(IRequestMessageBase requestMessage)
        {
            throw new NotImplementedException();
        }
    }
}
