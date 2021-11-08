// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasFunctionPluginFieldDataDTO : TeaModel {
        /// <summary>
        /// AliyunFunction
        /// </summary>
        [NameInMap("AliyunFunction")]
        [Validation(Required=false)]
        public string AliyunFunction { get; set; }

        /// <summary>
        /// AliyunService
        /// </summary>
        [NameInMap("AliyunService")]
        [Validation(Required=false)]
        public string AliyunService { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// EndPoint
        /// </summary>
        [NameInMap("EndPoint")]
        [Validation(Required=false)]
        public string EndPoint { get; set; }

        /// <summary>
        /// Function
        /// </summary>
        [NameInMap("Function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Params
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        /// <summary>
        /// Switch
        /// </summary>
        [NameInMap("Switch")]
        [Validation(Required=false)]
        public List<PaasSwitchCaseDTO> Switch { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
