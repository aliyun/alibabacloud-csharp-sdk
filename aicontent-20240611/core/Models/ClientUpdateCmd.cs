// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ClientUpdateCmd : TeaModel {
        /// <summary>
        /// <para>The company address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The list of allowed model IDs, separated by commas. An empty value indicates all models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("allowedModels")]
        [Validation(Required=false)]
        public string AllowedModels { get; set; }

        /// <summary>
        /// <para>The contact information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13800138000</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        /// <summary>
        /// <para>The customer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My customer</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remark</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
