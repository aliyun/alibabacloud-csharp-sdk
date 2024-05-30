// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateVerifySettingRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("GuideStep")]
        [Validation(Required=false)]
        public bool? GuideStep { get; set; }

        [NameInMap("PrivacyStep")]
        [Validation(Required=false)]
        public bool? PrivacyStep { get; set; }

        [NameInMap("ResultStep")]
        [Validation(Required=false)]
        public bool? ResultStep { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public string Solution { get; set; }

    }

}
