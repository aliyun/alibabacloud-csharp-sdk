// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class DescribeScreenSettingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LogoPower")]
        [Validation(Required=false)]
        public bool? LogoPower { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.XXXXXXXXXXX.jpg">https://img.alicdn.XXXXXXXXXXX.jpg</a></para>
        /// </summary>
        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://XXX.monitor.XXXXcom">https://XXX.monitor.XXXXcom</a></para>
        /// </summary>
        [NameInMap("MonitorUrl")]
        [Validation(Required=false)]
        public string MonitorUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B9A68671-BD84-55CD-807A-XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;positionId\&quot;:XX,\&quot;componentId\&quot;:XX,\&quot;date\&quot;:\&quot;XXX\&quot;},{\&quot;positionId\&quot;:X,\&quot;componentId\&quot;:X,\&quot;date\&quot;:\&quot;XXX\&quot;},{\&quot;positionId\&quot;:X,\&quot;componentId\&quot;:X,\&quot;date\&quot;:\&quot;XX\&quot;},{\&quot;positionId\&quot;:X,\&quot;componentId\&quot;:XX,\&quot;date\&quot;:\&quot;XXX\&quot;},{\&quot;positionId\&quot;:X,\&quot;componentId\&quot;:XX,\&quot;date\&quot;:\&quot;XX\&quot;},{\&quot;positionId\&quot;:X,\&quot;componentId\&quot;:XX,\&quot;date\&quot;:\&quot;XX\&quot;},{\&quot;positionId\&quot;:X,\&quot;componentId\&quot;:XX,\&quot;date\&quot;:\&quot;XXX\&quot;},{\&quot;positionId\&quot;:X,\&quot;componentId\&quot;:,\&quot;date\&quot;:\&quot;XXXX\&quot;}]</para>
        /// </summary>
        [NameInMap("ScreenDataMap")]
        [Validation(Required=false)]
        public string ScreenDataMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7849</para>
        /// </summary>
        [NameInMap("ScreenDefault")]
        [Validation(Required=false)]
        public int? ScreenDefault { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1004770</para>
        /// </summary>
        [NameInMap("ScreenId")]
        [Validation(Required=false)]
        public int? ScreenId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Daily Report</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
