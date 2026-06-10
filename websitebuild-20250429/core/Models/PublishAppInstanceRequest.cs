// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class PublishAppInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250821161210000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Deployment channel</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("DeployChannel")]
        [Validation(Required=false)]
        public string DeployChannel { get; set; }

        /// <summary>
        /// <para>Publish description</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_BY_NLB.nlb-jcvs5sm9l8um84zbfa</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Logical version number</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("LogicalNumber")]
        [Validation(Required=false)]
        public int? LogicalNumber { get; set; }

        /// <summary>
        /// <para>Publish number</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PublishNumber")]
        [Validation(Required=false)]
        public string PublishNumber { get; set; }

        /// <summary>
        /// <para>action</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUILD</para>
        /// </summary>
        [NameInMap("WeappAction")]
        [Validation(Required=false)]
        public string WeappAction { get; set; }

    }

}
