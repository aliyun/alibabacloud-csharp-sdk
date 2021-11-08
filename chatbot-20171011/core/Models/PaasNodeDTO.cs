// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasNodeDTO : TeaModel {
        /// <summary>
        /// Code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// PluginData
        /// </summary>
        [NameInMap("PluginData")]
        [Validation(Required=false)]
        public PaasPluginDataDTO PluginData { get; set; }

        /// <summary>
        /// Xx
        /// </summary>
        [NameInMap("Xx")]
        [Validation(Required=false)]
        public double? Xx { get; set; }

        /// <summary>
        /// Yy
        /// </summary>
        [NameInMap("Yy")]
        [Validation(Required=false)]
        public double? Yy { get; set; }

    }

}
