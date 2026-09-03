// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class GetTrialInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message. The value &quot;successful&quot; is returned on success. An error message is returned on failure.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The free trial properties. This parameter is returned only when a free trial record exists for the data source.</para>
        /// </summary>
        [NameInMap("TrialInfo")]
        [Validation(Required=false)]
        public GetTrialInfoResponseBodyTrialInfo TrialInfo { get; set; }
        public class GetTrialInfoResponseBodyTrialInfo : TeaModel {
            /// <summary>
            /// <para>Indicates whether the service is converted to pay-as-you-go after the free trial expires.</para>
            /// </summary>
            [NameInMap("KeepAfterTrialExpiration")]
            [Validation(Required=false)]
            public bool? KeepAfterTrialExpiration { get; set; }

            /// <summary>
            /// <para>The remaining number of free trial backup plans that can be created. The value 1 is returned if the free trial has not expired and no free trial backup plan has been created. Otherwise, the value 0 is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrialBackupPlanQuota")]
            [Validation(Required=false)]
            public long? TrialBackupPlanQuota { get; set; }

            /// <summary>
            /// <para>The expiration time of the free trial. UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1584597600</para>
            /// </summary>
            [NameInMap("TrialExpireTime")]
            [Validation(Required=false)]
            public long? TrialExpireTime { get; set; }

            /// <summary>
            /// <para>The start time of the free trial. UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1579413159</para>
            /// </summary>
            [NameInMap("TrialStartTime")]
            [Validation(Required=false)]
            public long? TrialStartTime { get; set; }

            /// <summary>
            /// <para>The remaining number of free trial backup vaults that can be created. The value 1 is returned if the free trial has not expired and no free trial backup vault has been created. Otherwise, the value 0 is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrialVaultQuota")]
            [Validation(Required=false)]
            public long? TrialVaultQuota { get; set; }

            /// <summary>
            /// <para>The release time of the free trial backup vault. UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594965600</para>
            /// </summary>
            [NameInMap("TrialVaultReleaseTime")]
            [Validation(Required=false)]
            public long? TrialVaultReleaseTime { get; set; }

        }

    }

}
