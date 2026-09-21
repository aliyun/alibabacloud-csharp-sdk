// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSasTrialRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests must use different tokens. The token supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. true: performs only a dry run without performing the actual request. false: performs the actual request. Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether the request is from the ECS console. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FromEcs")]
        [Validation(Required=false)]
        public bool? FromEcs { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
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
        /// <para>The reason for applying for the trial. This parameter is required for a second trial.</para>
        /// </summary>
        [NameInMap("RequestForm")]
        [Validation(Required=false)]
        public CreateSasTrialRequestRequestForm RequestForm { get; set; }
        public class CreateSasTrialRequestRequestForm : TeaModel {
            /// <summary>
            /// <para>The reason for applying for the trial.</para>
            /// 
            /// <b>Example:</b>
            /// <para>for poc</para>
            /// </summary>
            [NameInMap("TryReason")]
            [Validation(Required=false)]
            public string TryReason { get; set; }

        }

        /// <summary>
        /// <para>The trial type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Trial is not allowed.</description></item>
        /// <item><description><b>1</b>: First trial.</description></item>
        /// <item><description><b>2</b>: Second trial.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2623574.html">GetCanTrySas</a> operation to obtain this parameter. The trial can be started only when the value is not 0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TryType")]
        [Validation(Required=false)]
        public int? TryType { get; set; }

        /// <summary>
        /// <para>The trial edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2623574.html">GetCanTrySas</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TryVersion")]
        [Validation(Required=false)]
        public int? TryVersion { get; set; }

    }

}
