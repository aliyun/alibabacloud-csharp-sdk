// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryDigitalSignByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the access denial. This parameter is returned only if Resource Access Management (RAM) authentication fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request. A value of <c>OK</c> indicates that the request was successful. Other values indicate error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para><c>gmtModified</c>: The time when the signature was last modified.</para>
        /// </description></item>
        /// <item><description><para><c>creator</c>: The ID of the user who created the signature.</para>
        /// </description></item>
        /// <item><description><para><c>signName</c>: The name of the digital SMS signature.</para>
        /// </description></item>
        /// <item><description><para><c>qualificationId</c>: The ID of the qualification. You can create qualifications in the console or by calling an API operation.</para>
        /// </description></item>
        /// <item><description><para><c>signIndustry</c>: The industry type. Valid values: <c>0</c> (General) and <c>1</c> (E-commerce).</para>
        /// </description></item>
        /// <item><description><para><c>signVersion</c>: The version of the signature. This value is updated for each new version. The current version is 1.</para>
        /// </description></item>
        /// <item><description><para><c>telecomRegisterStatus</c>: The filing status with China Telecom. Valid values: <c>0</c> (Filing Failed), <c>3</c> (Filing Successful), <c>-1</c> (Filing in Progress), and <c>-2</c> (Not Filed).</para>
        /// </description></item>
        /// <item><description><para><c>signCode</c>: The code of the digital SMS signature.</para>
        /// </description></item>
        /// <item><description><para><c>gmtCreate</c>: The time when the signature was created.</para>
        /// </description></item>
        /// <item><description><para><c>signId</c>: The ID of the signature. This is a unique identifier.</para>
        /// </description></item>
        /// <item><description><para><c>mobileRegisterStatus</c>: The filing status with China Mobile.</para>
        /// </description></item>
        /// <item><description><para><c>SignSource</c>: The source of the signature. Valid values:</para>
        /// </description></item>
        /// <item><description><para><c>mobileAvailableStatus</c>: The availability status with China Mobile. Valid values: <c>0</c> (Unavailable) and <c>1</c> (Available). We recommend that you select an available signature when you create a template or send a digital SMS message.</para>
        /// </description></item>
        /// <item><description><para><c>unicomRegisterStatus</c>: The filing status with China Unicom. Valid values: <c>0</c> (Filing Failed), <c>3</c> (Filing Successful), <c>-1</c> (Filing in Progress), and <c>-2</c> (Not Filed).</para>
        /// </description></item>
        /// <item><description><para><c>unicomAvailableStatus</c>: The availability status with China Unicom. Valid values: <c>0</c> (Unavailable) and <c>1</c> (Available). We recommend that you select an available signature when you create a template or send a digital SMS message.</para>
        /// </description></item>
        /// <item><description><para><c>telecomAvailableStatus</c>: The availability status with China Telecom. Valid values: <c>0</c> (Unavailable) and <c>1</c> (Available). We recommend that you select an available signature when you create a template or send a digital SMS message.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Data&quot;: {
        ///     &quot;gmtModified&quot;: 1770005896000,
        ///     &quot;creator&quot;: &quot;UID:1498275912899720&quot;,
        ///     &quot;signName&quot;: &quot;驳回理由&quot;,
        ///     &quot;qualificationId&quot;: 2757722,
        ///     &quot;qualificationVersion&quot;: 1768974751432,
        ///     &quot;signIndustry&quot;: 0,
        ///     &quot;registerStatueReason&quot;: {},
        ///     &quot;signVersion&quot;: 1,
        ///     &quot;remark&quot;: &quot;&quot;,
        ///     &quot;telecomRegisterStatus&quot;: -1,
        ///     &quot;signCode&quot;: &quot;DIGSIGN_100000168688001_1769050485148_pYZu1&quot;,
        ///     &quot;gmtCreate&quot;: 1769050485000,
        ///     &quot;signId&quot;: 22784769,
        ///     &quot;mobileRegisterStatus&quot;: -1,
        ///     &quot;signSource&quot;: 0,
        ///     &quot;mobileAvailableStatus&quot;: 0,
        ///     &quot;attachmentList&quot;: [],
        ///     &quot;unicomRegisterStatus&quot;: 3,
        ///     &quot;unicomAvailableStatus&quot;: 1,
        ///     &quot;signType&quot;: 1,
        ///     &quot;telecomAvailableStatus&quot;: 0,
        ///     &quot;extendMessage&quot;: &quot;{}&quot;
        ///   },</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
