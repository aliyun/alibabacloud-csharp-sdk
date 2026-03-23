// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class UnRegisterApAssetRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AssetApgroupId")]
        [Validation(Required=false)]
        public long? AssetApgroupId { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        [NameInMap("UseFor")]
        [Validation(Required=false)]
        public int? UseFor { get; set; }

    }

}
