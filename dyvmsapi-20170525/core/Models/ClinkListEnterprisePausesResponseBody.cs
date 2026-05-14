// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListEnterprisePausesResponseBody : TeaModel {
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
        public ClinkListEnterprisePausesResponseBodyData Data { get; set; }
        public class ClinkListEnterprisePausesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <para>企业置忙状态列表</para>
            /// </summary>
            [NameInMap("EnterprisePauses")]
            [Validation(Required=false)]
            public List<ClinkListEnterprisePausesResponseBodyDataEnterprisePauses> EnterprisePauses { get; set; }
            public class ClinkListEnterprisePausesResponseBodyDataEnterprisePauses : TeaModel {
                /// <summary>
                /// <para>置忙状态Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>默认状态，0：不是；1：是</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public long? IsDefault { get; set; }

                /// <summary>
                /// <para>休息状态，0：不是；1：是</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsRest")]
                [Validation(Required=false)]
                public string IsRest { get; set; }

                /// <summary>
                /// <para>置忙状态描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("PauseStatus")]
                [Validation(Required=false)]
                public string PauseStatus { get; set; }

                /// <summary>
                /// <para>优先级，数字越小优先级越高</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Sort")]
                [Validation(Required=false)]
                public long? Sort { get; set; }

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
        /// <para>7BF47617-7851-48F7-A3A1-2021342A78E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
