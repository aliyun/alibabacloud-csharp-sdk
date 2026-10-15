// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqQueryAbilityRequest : TeaModel {
        /// <summary>
        /// <para>The dataset ID.</para>
        /// <para>Navigate to Workbench &gt; Datasets, open the desired dataset, and find the cubeId in the URL.</para>
        /// <para>In multi-table scenarios, leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-****-3c744528014b</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>The list of multiple dataset IDs.
        /// The model selects one or more tables from the list based on the question to generate an answer. This parameter is required in multi-table scenarios and is not needed in single-table scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7****-3c744528014b,a876asd***yhashd2</para>
        /// </summary>
        [NameInMap("MultipleCubeIds")]
        [Validation(Required=false)]
        public string MultipleCubeIds { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// <remarks>
        /// <para>Notice: If this parameter is not specified, data is queried as the organization owner by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-****-3c744528014b</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The question text.</para>
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
