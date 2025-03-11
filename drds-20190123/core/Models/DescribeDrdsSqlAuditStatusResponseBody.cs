// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsSqlAuditStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsSqlAuditStatusResponseBodyData Data { get; set; }
        public class DescribeDrdsSqlAuditStatusResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeDrdsSqlAuditStatusResponseBodyDataData> Data { get; set; }
            public class DescribeDrdsSqlAuditStatusResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <para>Indicates whether the complete report of the SQL audit is supported. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Detailed")]
                [Validation(Required=false)]
                public string Detailed { get; set; }

                /// <summary>
                /// <para>Indicates whether the SQL audit feature is enabled for the database. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                /// <summary>
                /// <para>The UID of the external delivery.</para>
                /// <remarks>
                /// <para>This parameter is returned only if external log delivery is enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("ExtraAliUid")]
                [Validation(Required=false)]
                public long? ExtraAliUid { get; set; }

                /// <summary>
                /// <para>The Log Service Logstore from which logs are delivered.</para>
                /// <remarks>
                /// <para>This parameter is returned only if external log delivery is enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ExtraSlsLogStore")]
                [Validation(Required=false)]
                public string ExtraSlsLogStore { get; set; }

                /// <summary>
                /// <para>The Log Service project from which logs are delivered.</para>
                /// <remarks>
                /// <para>This parameter is returned only if external log delivery is enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ExtraSlsProject")]
                [Validation(Required=false)]
                public string ExtraSlsProject { get; set; }

                /// <summary>
                /// <para>Indicates whether external log delivery is enabled. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ExtraWriteEnabled")]
                [Validation(Required=false)]
                public bool? ExtraWriteEnabled { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC3ABA3E-0F8A-4596-9104-F5155C******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
