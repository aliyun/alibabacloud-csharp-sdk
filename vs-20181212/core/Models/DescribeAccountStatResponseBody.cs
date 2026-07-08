// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeAccountStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of device spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("GroupLimit")]
        [Validation(Required=false)]
        public long? GroupLimit { get; set; }

        /// <summary>
        /// <para>Number of device groups in the current region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("GroupNum")]
        [Validation(Required=false)]
        public long? GroupNum { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1165*****601</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Maximum number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TemplateLimit")]
        [Validation(Required=false)]
        public long? TemplateLimit { get; set; }

        /// <summary>
        /// <para>Current number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TemplateNum")]
        [Validation(Required=false)]
        public long? TemplateNum { get; set; }

    }

}
