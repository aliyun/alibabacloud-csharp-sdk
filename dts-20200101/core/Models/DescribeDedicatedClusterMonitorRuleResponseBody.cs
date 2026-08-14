// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDedicatedClusterMonitorRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The CPU alert threshold, in percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("CpuAlarmThreshold")]
        [Validation(Required=false)]
        public string CpuAlarmThreshold { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsClustervcwn1oeyu5fx4yf</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>The disk alert threshold, in percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DiskAlarmThreshold")]
        [Validation(Required=false)]
        public string DiskAlarmThreshold { get; set; }

        /// <summary>
        /// <para>The DU alert threshold, in percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46</para>
        /// </summary>
        [NameInMap("DuAlarmThreshold")]
        [Validation(Required=false)]
        public string DuAlarmThreshold { get; set; }

        /// <summary>
        /// <para>The error code returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The memory alert threshold, in percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("MemAlarmThreshold")]
        [Validation(Required=false)]
        public string MemAlarmThreshold { get; set; }

        /// <summary>
        /// <para>The alert switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled.</description></item>
        /// <item><description><b>0</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NoticeSwitch")]
        [Validation(Required=false)]
        public string NoticeSwitch { get; set; }

        /// <summary>
        /// <para>The phone numbers that receive alerts. If there are multiple phone numbers, they are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>186****7653</para>
        /// </summary>
        [NameInMap("Phones")]
        [Validation(Required=false)]
        public string Phones { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
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
        public string Success { get; set; }

    }

}
