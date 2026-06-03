// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetDBAuditCountListResponseBody : TeaModel {
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public List<GetDBAuditCountListResponseBodyDbList> DbList { get; set; }
        public class GetDBAuditCountListResponseBodyDbList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            [NameInMap("DbAddresses")]
            [Validation(Required=false)]
            public List<string> DbAddresses { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public int? DbType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Mysql</para>
            /// </summary>
            [NameInMap("DbTypeName")]
            [Validation(Required=false)]
            public string DbTypeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5700</para>
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public int? DbVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("DbVersionName")]
            [Validation(Required=false)]
            public string DbVersionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B217656-2267-4FBF-B26C-CDD201BDC3B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
