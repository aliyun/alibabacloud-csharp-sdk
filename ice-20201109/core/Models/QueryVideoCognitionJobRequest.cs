// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryVideoCognitionJobRequest : TeaModel {
        [NameInMap("IncludeResults")]
        [Validation(Required=false)]
        public QueryVideoCognitionJobRequestIncludeResults IncludeResults { get; set; }
        public class QueryVideoCognitionJobRequestIncludeResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedAsr")]
            [Validation(Required=false)]
            public bool? NeedAsr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedOcr")]
            [Validation(Required=false)]
            public bool? NeedOcr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedProcess")]
            [Validation(Required=false)]
            public bool? NeedProcess { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

    }

}
