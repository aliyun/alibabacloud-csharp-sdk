// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of DAGs.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDagsResponseBodyData Data { get; set; }
        public class ListDagsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The entities returned.</para>
            /// </summary>
            [NameInMap("Dags")]
            [Validation(Required=false)]
            public List<ListDagsResponseBodyDataDags> Dags { get; set; }
            public class ListDagsResponseBodyDataDags : TeaModel {
                /// <summary>
                /// <para>The data timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1605052800000</para>
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1605052800000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1736629400048545</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The DAG ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>351249682</para>
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1605052800000</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The actual running time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1605052800000</para>
                /// </summary>
                [NameInMap("Gmtdate")]
                [Validation(Required=false)]
                public long? Gmtdate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1605052800000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the DAG.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_dag</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The sequence number of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("OpSeq")]
                [Validation(Required=false)]
                public long? OpSeq { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>112345</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1605052800000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The status of the DAG. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATED</description></item>
                /// <item><description>RUNNING</description></item>
                /// <item><description>FAILURE</description></item>
                /// <item><description>SUCCESS</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FAILURE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the DAG. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MANUAL: DAG for a manually triggered workflow</description></item>
                /// <item><description>SMOKE_TEST: DAG for a smoke testing workflow</description></item>
                /// <item><description>SUPPLY_DATA: DAG for a data backfill instance</description></item>
                /// <item><description>BUSINESS_PROCESS_DAG: DAG for a one-time workflow</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MANUAL_FLOW</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7782a299-b291-4fee-8424-cf8058efa8e8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
