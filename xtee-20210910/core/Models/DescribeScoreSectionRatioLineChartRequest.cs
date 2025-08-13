// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeScoreSectionRatioLineChartRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for request and response messages, with a default value of <b>zh</b>. Values: </para>
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
        /// <para>Start time, accurate to milliseconds (ms).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1751249559000</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>Bypass event code</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_amnhke2482</para>
        /// </summary>
        [NameInMap("byPassEventCodes")]
        [Validation(Required=false)]
        public string ByPassEventCodes { get; set; }

        /// <summary>
        /// <para>End time, accurate to milliseconds (ms).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748491200000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Main event code</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_avcqzc3714</para>
        /// </summary>
        [NameInMap("mainEventCodes")]
        [Validation(Required=false)]
        public string MainEventCodes { get; set; }

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
        /// <para>Shunt event code</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_amnhke2488</para>
        /// </summary>
        [NameInMap("shuntEventCodes")]
        [Validation(Required=false)]
        public string ShuntEventCodes { get; set; }

    }

}
