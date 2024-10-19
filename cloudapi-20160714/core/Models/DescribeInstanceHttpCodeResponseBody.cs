// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceHttpCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status codes.</para>
        /// </summary>
        [NameInMap("InstanceHttpCode")]
        [Validation(Required=false)]
        public DescribeInstanceHttpCodeResponseBodyInstanceHttpCode InstanceHttpCode { get; set; }
        public class DescribeInstanceHttpCodeResponseBodyInstanceHttpCode : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceHttpCodeResponseBodyInstanceHttpCodeMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceHttpCodeResponseBodyInstanceHttpCodeMonitorItem : TeaModel {
                /// <summary>
                /// <para>The HTTP status code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>404</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The corresponding value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD00F8C0-311B-54A9-ADE2-2436771012DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
