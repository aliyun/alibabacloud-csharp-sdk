// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetSelectionSelectedTargetRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the asset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e6ab33d-4e00-4581-ac16-0dd1f9ad****</para>
        /// </summary>
        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

        /// <summary>
        /// <para>The details of queries.</para>
        /// </summary>
        [NameInMap("TargetList")]
        [Validation(Required=false)]
        public List<string> TargetList { get; set; }

    }

}
