// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqQueryAbilityRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the dataset. To obtain the ID, navigate to \<em>\<em>Workbench\</em>\</em> &gt; \<em>\<em>Dataset\</em>\</em> in the Quick BI console. Open the dataset and find the \<c>cubeId\\</c> in the URL.</para>
        /// <para>In multi-table scenarios, this parameter must be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-****-3c744528014b</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>A list of dataset IDs. The model selects one or more tables from the list to generate an answer based on the question. This parameter is required for multi-table scenarios and is not used for single-table scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7****-3c744528014b,a876asd***yhashd2</para>
        /// </summary>
        [NameInMap("MultipleCubeIds")]
        [Validation(Required=false)]
        public string MultipleCubeIds { get; set; }

        /// <summary>
        /// <para>The ID of the user.</para>
        /// <remarks>
        /// <para>Notice: If you do not specify this parameter, data is queried as the organization owner by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-****-3c744528014b</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The question in text format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UserQuestion")]
        [Validation(Required=false)]
        public string UserQuestion { get; set; }

    }

}
