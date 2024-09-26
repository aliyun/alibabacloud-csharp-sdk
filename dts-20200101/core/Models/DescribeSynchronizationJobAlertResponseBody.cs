// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>The mobile phone numbers that receive latency-related alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("DelayAlertPhone")]
        [Validation(Required=false)]
        public string DelayAlertPhone { get; set; }

        /// <summary>
        /// <para>Indicates whether task latency is monitored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b>: yes</description></item>
        /// <item><description><b>disable</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("DelayAlertStatus")]
        [Validation(Required=false)]
        public string DelayAlertStatus { get; set; }

        /// <summary>
        /// <para>The threshold for triggering latency alerts. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DelayOverSeconds")]
        [Validation(Required=false)]
        public string DelayOverSeconds { get; set; }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers that receive status-related alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("ErrorAlertPhone")]
        [Validation(Required=false)]
        public string ErrorAlertPhone { get; set; }

        /// <summary>
        /// <para>Indicates whether task status is monitored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b>: yes</description></item>
        /// <item><description><b>disable</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("ErrorAlertStatus")]
        [Validation(Required=false)]
        public string ErrorAlertStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210ec20e16055205968635339d****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Forward</b></para>
        /// </description></item>
        /// <item><description><para><b>Reverse</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when the topology of data synchronization is two-way synchronization.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>The ID of the data synchronization instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kxz1170c10p****</para>
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        /// <summary>
        /// <para>The name of the data synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Polar MySQL_TO_RDS MySQL</para>
        /// </summary>
        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

    }

}
