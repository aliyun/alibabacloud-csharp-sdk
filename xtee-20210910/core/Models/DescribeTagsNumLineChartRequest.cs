// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeTagsNumLineChartRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The start time, in milliseconds (ms).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1751249559000</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>The bypass event codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_amnhke2482</para>
        /// </summary>
        [NameInMap("byPassEventCodes")]
        [Validation(Required=false)]
        public string ByPassEventCodes { get; set; }

        /// <summary>
        /// <para>The end time, in milliseconds (ms).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749002991000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The main event codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_amnhke2482</para>
        /// </summary>
        [NameInMap("mainEventCodes")]
        [Validation(Required=false)]
        public string MainEventCodes { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The diversion event codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_amnhke2488</para>
        /// </summary>
        [NameInMap("shuntEventCodes")]
        [Validation(Required=false)]
        public string ShuntEventCodes { get; set; }

    }

}
