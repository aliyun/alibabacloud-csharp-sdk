// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetCompliancePackShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The compliance package ID.</para>
        /// <para>For more information about how to obtain the compliance package ID, see <a href="https://help.aliyun.com/document_detail/263332.html">ListCompliancePacks</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-a8a8626622af0082****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The tags of the resource. This parameter is deprecated and takes no effect if it is specified.</para>
        /// <para>You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        [Obsolete]
        public string TagShrink { get; set; }

    }

}
