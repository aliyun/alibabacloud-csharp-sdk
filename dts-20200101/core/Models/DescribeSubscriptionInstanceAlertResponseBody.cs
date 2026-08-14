// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionInstanceAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>The mobile phone number of the contact for latency alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13465****</para>
        /// </summary>
        [NameInMap("DelayAlertPhone")]
        [Validation(Required=false)]
        public string DelayAlertPhone { get; set; }

        /// <summary>
        /// <para>Indicates whether latency alerting is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b>: Enabled.</description></item>
        /// <item><description><b>disable</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("DelayAlertStatus")]
        [Validation(Required=false)]
        public string DelayAlertStatus { get; set; }

        /// <summary>
        /// <para>The threshold for triggering latency alerts. Unit: seconds. The value must be an integer. A value of 10 seconds is recommended.</para>
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
        /// <para>The mobile phone number of the contact for error alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13555*****</para>
        /// </summary>
        [NameInMap("ErrorAlertPhone")]
        [Validation(Required=false)]
        public string ErrorAlertPhone { get; set; }

        /// <summary>
        /// <para>Indicates whether error alerting is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b>: Enabled.</description></item>
        /// <item><description><b>disable</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("ErrorAlertStatus")]
        [Validation(Required=false)]
        public string ErrorAlertStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210ec2e116055198849072222d****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The change tracking instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsl8zl9ek6292****</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceID")]
        [Validation(Required=false)]
        public string SubscriptionInstanceID { get; set; }

        /// <summary>
        /// <para>The name of the change tracking instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceName")]
        [Validation(Required=false)]
        public string SubscriptionInstanceName { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
