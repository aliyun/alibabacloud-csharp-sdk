// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ResetAndroidInstancesInGroupRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud phone instances.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        [NameInMap("IgnoreParamValidation")]
        [Validation(Required=false)]
        public bool? IgnoreParamValidation { get; set; }

        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

        [NameInMap("SettingResetType")]
        [Validation(Required=false)]
        public int? SettingResetType { get; set; }

    }

}
