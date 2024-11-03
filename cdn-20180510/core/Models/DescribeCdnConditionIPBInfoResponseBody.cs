// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnConditionIPBInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<DescribeCdnConditionIPBInfoResponseBodyDatas> Datas { get; set; }
        public class DescribeCdnConditionIPBInfoResponseBodyDatas : TeaModel {
            /// <summary>
            /// <para>The configuration value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;[{\&quot;text\&quot;:\&quot;阿鲁巴\&quot;,\&quot;value\&quot;:\&quot;AW\&quot;}]&quot;</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C4AA72D-8C00-1113-BD68-8BC4E3CF4FF6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
