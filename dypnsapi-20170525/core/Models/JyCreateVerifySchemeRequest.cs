// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class JyCreateVerifySchemeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CmApiCode")]
        [Validation(Required=false)]
        public long? CmApiCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CtApiCode")]
        [Validation(Required=false)]
        public long? CtApiCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CuApiCode")]
        [Validation(Required=false)]
        public long? CuApiCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PackName")]
        [Validation(Required=false)]
        public string PackName { get; set; }

        [NameInMap("PackSign")]
        [Validation(Required=false)]
        public string PackSign { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

    }

}
