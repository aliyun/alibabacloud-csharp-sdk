// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceQpsResponseBody : TeaModel {
        [NameInMap("InstanceQps")]
        [Validation(Required=false)]
        public DescribeInstanceQpsResponseBodyInstanceQps InstanceQps { get; set; }
        public class DescribeInstanceQpsResponseBodyInstanceQps : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceQpsResponseBodyInstanceQpsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceQpsResponseBodyInstanceQpsMonitorItem : TeaModel {
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ004</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
