// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class SaveApgroupPortalConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApgroupId")]
        [Validation(Required=false)]
        public long? ApgroupId { get; set; }

        [NameInMap("AppAuthUrl")]
        [Validation(Required=false)]
        public string AppAuthUrl { get; set; }

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

        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSecret")]
        [Validation(Required=false)]
        public string AuthSecret { get; set; }

        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        [NameInMap("ClientDownload")]
        [Validation(Required=false)]
        public int? ClientDownload { get; set; }

        [NameInMap("ClientUpload")]
        [Validation(Required=false)]
        public int? ClientUpload { get; set; }

        [NameInMap("Countdown")]
        [Validation(Required=false)]
        public int? Countdown { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public int? Network { get; set; }

        [NameInMap("PortalTypes")]
        [Validation(Required=false)]
        public string PortalTypesShrink { get; set; }

        [NameInMap("PortalUrl")]
        [Validation(Required=false)]
        public string PortalUrl { get; set; }

        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public long? TimeStamp { get; set; }

        [NameInMap("TotalDownload")]
        [Validation(Required=false)]
        public int? TotalDownload { get; set; }

        [NameInMap("TotalUpload")]
        [Validation(Required=false)]
        public int? TotalUpload { get; set; }

        [NameInMap("WebAuthUrl")]
        [Validation(Required=false)]
        public string WebAuthUrl { get; set; }

        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string Whitelist { get; set; }

    }

}
