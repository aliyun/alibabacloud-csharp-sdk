// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class AddSampleDataByTextRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>List data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testA \n testB</para>
        /// </summary>
        [NameInMap("dataValue")]
        [Validation(Required=false)]
        public string DataValue { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Sample UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1806507582222226
        /// _saf_sample_split_coupon_abuse_saf_sample_split_mobile_saf_sample_split_pass</para>
        /// </summary>
        [NameInMap("sampleBatchUuid")]
        [Validation(Required=false)]
        public string SampleBatchUuid { get; set; }

    }

}
