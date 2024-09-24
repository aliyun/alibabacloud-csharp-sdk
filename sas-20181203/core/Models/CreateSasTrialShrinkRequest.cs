// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSasTrialShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the request is redirected from the Elastic Compute Service (ECS) console. Valid values:</para>
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
        /// <para>The language of the content within the request and response. Valid values:</para>
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
        /// <para>The reason why you apply for the trial. You must specify the reason for the second trial.</para>
        /// </summary>
        [NameInMap("RequestForm")]
        [Validation(Required=false)]
        public string RequestFormShrink { get; set; }

        /// <summary>
        /// <para>The trial type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: trial prohibited</description></item>
        /// <item><description><b>1</b>: first trial</description></item>
        /// <item><description><b>2</b>: second trial</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2623574.html">GetCanTrySas</a> operation to obtain the trial type. You can start a trial only if this parameter is not set to 0.</para>
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
        /// <item><description><b>3</b>: Enterprise</description></item>
        /// <item><description><b>7</b>: Ultimate</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2623574.html">GetCanTrySas</a> operation to obtain the trial edition.</para>
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
