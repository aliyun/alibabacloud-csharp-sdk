// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppSeoStatusRequest : TeaModel {
        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250814102215000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Domain name</para>
        /// 
        /// <b>Example:</b>
        /// <para>yjdw.bpu.edu.cn-waf</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Search engine type</para>
        /// 
        /// <b>Example:</b>
        /// <para>type</para>
        /// </summary>
        [NameInMap("SeType")]
        [Validation(Required=false)]
        public string SeType { get; set; }

    }

}
