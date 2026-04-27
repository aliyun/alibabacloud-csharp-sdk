// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudBatchCreateAgentResponseBody : TeaModel {
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
        public CloudBatchCreateAgentResponseBodyData Data { get; set; }
        public class CloudBatchCreateAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>成功创建的座席号</para>
            /// 
            /// <b>Example:</b>
            /// <para>100,101,102,103</para>
            /// </summary>
            [NameInMap("Cnos")]
            [Validation(Required=false)]
            public string Cnos { get; set; }

            /// <summary>
            /// <para>创建座席失败数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public string Fail { get; set; }

            /// <summary>
            /// <para>座席创建成功,绑定技能失败的数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Other")]
            [Validation(Required=false)]
            public string Other { get; set; }

            /// <summary>
            /// <para>创建座席成功数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public string Success { get; set; }

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
