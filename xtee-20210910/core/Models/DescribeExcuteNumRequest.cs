// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeExcuteNumRequest : TeaModel {
        /// <summary>
        /// <para>Service code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf_all</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>This field is currently unused and has no query significance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>暂时不需要传入</para>
        /// </summary>
        [NameInMap("Degree")]
        [Validation(Required=false)]
        public string Degree { get; set; }

        /// <summary>
        /// <para>End date, format yyyy-MM-dd, e.g., 2025-03-13.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-15</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Set the language type for requests and received messages, default value is <b>zh</b>. Values:</para>
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
        /// <para>Request source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>220.250.21.83</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>Start date, format yyyy-MM-dd, e.g., 2025-03-10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-10</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
