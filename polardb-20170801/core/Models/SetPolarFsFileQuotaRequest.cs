// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class SetPolarFsFileQuotaRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FilePathQuotas")]
        [Validation(Required=false)]
        public List<SetPolarFsFileQuotaRequestFilePathQuotas> FilePathQuotas { get; set; }
        public class SetPolarFsFileQuotaRequestFilePathQuotas : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>/a/project</para>
            /// </summary>
            [NameInMap("FilePathId")]
            [Validation(Required=false)]
            public string FilePathId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxDepth")]
            [Validation(Required=false)]
            public int? MaxDepth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1,2</para>
            /// </summary>
            [NameInMap("QuotaIds")]
            [Validation(Required=false)]
            public string QuotaIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>missing</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

    }

}
