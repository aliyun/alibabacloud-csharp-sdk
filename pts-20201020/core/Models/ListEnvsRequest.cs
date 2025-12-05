// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListEnvsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the environment. If you specify this parameter, the operation returns the information about the environment identified by the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10YPA8H</para>
        /// </summary>
        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        /// <summary>
        /// <para>The keyword of the environment name. If you specify this parameter, the operation returns the information about the environments whose names contain the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-create</para>
        /// </summary>
        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of environments per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
