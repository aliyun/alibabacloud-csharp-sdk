// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeConditionIPBInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<DescribeConditionIPBInfoResponseBodyDatas> Datas { get; set; }
        public class DescribeConditionIPBInfoResponseBodyDatas : TeaModel {
            /// <summary>
            /// <para>The returned data details, including the name of the country, ISP, or region and the corresponding identifier code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;text\&quot;:\&quot;安徽\&quot;,\&quot;value\&quot;:\&quot;340000\&quot;},{\&quot;text\&quot;:\&quot;北京\&quot;,\&quot;value\&quot;:\&quot;110000\&quot;},{\&quot;text\&quot;:\&quot;重庆\&quot;,\&quot;value\&quot;:\&quot;500000\&quot;}]</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
