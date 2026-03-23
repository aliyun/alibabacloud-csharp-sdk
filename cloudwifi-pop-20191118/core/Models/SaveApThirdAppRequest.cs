// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class SaveApThirdAppRequest : TeaModel {
        [NameInMap("AddStyle")]
        [Validation(Required=false)]
        public int? AddStyle { get; set; }

        [NameInMap("ApAssetId")]
        [Validation(Required=false)]
        public long? ApAssetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("AppData")]
        [Validation(Required=false)]
        public string AppData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

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

        [NameInMap("ThirdAppName")]
        [Validation(Required=false)]
        public string ThirdAppName { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
