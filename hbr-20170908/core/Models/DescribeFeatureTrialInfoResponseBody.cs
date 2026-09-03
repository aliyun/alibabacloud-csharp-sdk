// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeFeatureTrialInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. The value 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the feature is activated. The value false is returned if the feature is not activated. In this case, InTrialPeriod is false and TrialExpireTime is 0.</para>
        /// </summary>
        [NameInMap("FeatureEnabled")]
        [Validation(Required=false)]
        public bool? FeatureEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether the feature is within the free trial period. The value false is returned if the feature is not activated or the free trial has expired.</para>
        /// </summary>
        [NameInMap("InTrialPeriod")]
        [Validation(Required=false)]
        public bool? InTrialPeriod { get; set; }

        /// <summary>
        /// <para>The returned message. The value &quot;successful&quot; is returned upon success. An error message is returned upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The expiration time of the free trial. The value is a UNIX timestamp, in seconds. The value 0 is returned if the feature is not activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1584597600</para>
        /// </summary>
        [NameInMap("TrialExpireTime")]
        [Validation(Required=false)]
        public long? TrialExpireTime { get; set; }

    }

}
