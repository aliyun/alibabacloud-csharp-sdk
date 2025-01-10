// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryReceiverDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>UserName,NickName,Gender,Birthday,Mobile</para>
        /// </summary>
        [NameInMap("DataSchema")]
        [Validation(Required=false)]
        public string DataSchema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90f0243616#401#b68c2af70b9664b2843f90fd3630b1a3-1650779410#<a href="mailto:xxx@demo.aliyun.com">xxx@demo.aliyun.com</a></para>
        /// </summary>
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>361</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryReceiverDetailResponseBodyData Data { get; set; }
        public class QueryReceiverDetailResponseBodyData : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<QueryReceiverDetailResponseBodyDataDetail> Detail { get; set; }
            public class QueryReceiverDetailResponseBodyDataDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-09-29T13:28Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;Domains\&quot;: [\&quot;a.example.net\&quot;, \&quot;b.example.net\&quot;, \&quot;c.example.net\&quot;, \&quot;d.example.net\&quot;]}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a***@example.net</para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1569734892</para>
                /// </summary>
                [NameInMap("UtcCreateTime")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

        }

    }

}
