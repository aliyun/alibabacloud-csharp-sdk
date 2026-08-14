// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>The mobile phone number of the contact for latency alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("DelayAlertPhone")]
        [Validation(Required=false)]
        public string DelayAlertPhone { get; set; }

        /// <summary>
        /// <para>Indicates whether latency status monitoring is enabled. Valid values:</para>
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
        /// <para>The threshold that triggers a latency alert. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DelayOverSeconds")]
        [Validation(Required=false)]
        public string DelayOverSeconds { get; set; }

        /// <summary>
        /// <para>The error code returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
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
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("ErrorAlertPhone")]
        [Validation(Required=false)]
        public string ErrorAlertPhone { get; set; }

        /// <summary>
        /// <para>Indicates whether error status monitoring is enabled. Valid values:</para>
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
        /// <para>The ID of the data migration instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtslb9113qq11n****</para>
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        /// <summary>
        /// <para>The name of the data migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zwy-test5</para>
        /// </summary>
        [NameInMap("MigrationJobName")]
        [Validation(Required=false)]
        public string MigrationJobName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CFB89C51-6F03-519C-A921-AAE28D50AEFB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
