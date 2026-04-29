// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudListAssignedAgentGroupResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudListAssignedAgentGroupResponseBodyData Data { get; set; }
        public class CloudListAssignedAgentGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>返回数据</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudListAssignedAgentGroupResponseBodyDataList> List { get; set; }
            public class CloudListAssignedAgentGroupResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name1</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public long? Cname { get; set; }

                /// <summary>
                /// <para>座席编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>59517582</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-30 06:12:30</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>呼叫中心编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>7122600</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>外呼组编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZO874912</para>
                /// </summary>
                [NameInMap("Gno")]
                [Validation(Required=false)]
                public string Gno { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
