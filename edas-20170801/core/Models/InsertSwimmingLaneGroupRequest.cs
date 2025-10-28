// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertSwimmingLaneGroupRequest : TeaModel {
        /// <summary>
        /// <para>IDs of all applications that are related to the lane group. Separate multiple applications with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bdb251cc-02a6-48dd-891b-2ab21b25****,ee33ed0c-fddc-47b5-9f63-e1ccc4be****</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        /// <summary>
        /// <para>The ingress application. The application is in the EDAS:{application ID} format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDAS:5cc89013-9232-4b36-b3eb-ff89b3d2****</para>
        /// </summary>
        [NameInMap("EntryApp")]
        [Validation(Required=false)]
        public string EntryApp { get; set; }

        /// <summary>
        /// <para>The ID of the custom namespace. The ID is in the physical region ID:custom namespace identifier format. Example: cn-hangzhou:test.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou:test</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>The name of the lane group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
