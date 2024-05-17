// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateOpenSingleDataRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppMaxVersion")]
        [Validation(Required=false)]
        public string AppMaxVersion { get; set; }

        [NameInMap("AppMinVersion")]
        [Validation(Required=false)]
        public string AppMinVersion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("CheckOnline")]
        [Validation(Required=false)]
        public bool? CheckOnline { get; set; }

        [NameInMap("ExtAttrStr")]
        [Validation(Required=false)]
        public string ExtAttrStr { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LinkToken")]
        [Validation(Required=false)]
        public string LinkToken { get; set; }

        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ThirdMsgId")]
        [Validation(Required=false)]
        public string ThirdMsgId { get; set; }

        [NameInMap("ValidTimeEnd")]
        [Validation(Required=false)]
        public long? ValidTimeEnd { get; set; }

        [NameInMap("ValidTimeStart")]
        [Validation(Required=false)]
        public long? ValidTimeStart { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
