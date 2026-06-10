// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class RollbackAppInstancePublishRequest : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
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
        /// <para>Publish number</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PublishNumber")]
        [Validation(Required=false)]
        public string PublishNumber { get; set; }

        /// <summary>
        /// <para>Quick rollback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("QuickRollback")]
        [Validation(Required=false)]
        public string QuickRollback { get; set; }

    }

}
