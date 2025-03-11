// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the details of the result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDrdsInstanceResponseBodyData Data { get; set; }
        public class CreateDrdsInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates the ID of the instance.</para>
            /// </summary>
            [NameInMap("DrdsInstanceIdList")]
            [Validation(Required=false)]
            public CreateDrdsInstanceResponseBodyDataDrdsInstanceIdList DrdsInstanceIdList { get; set; }
            public class CreateDrdsInstanceResponseBodyDataDrdsInstanceIdList : TeaModel {
                [NameInMap("drdsInstanceIdList")]
                [Validation(Required=false)]
                public List<string> DrdsInstanceIdList { get; set; }

            }

            /// <summary>
            /// <para>Indicates the ID of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111111111111</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

        }

        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D99D4644-A70D-49A3-B8B4-767ACC50SE2R</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
