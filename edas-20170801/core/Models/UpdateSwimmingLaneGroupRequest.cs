// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateSwimmingLaneGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of application IDs related to the lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8e7689af-6ddd-4676-8ee6-5fbecdf2****,f72deaac-26ba-429a-948d-5fa47c4a****,5049d2c8-f997-4fc9-92a2-153506a6****,99a2d4b5-99a5-4e25-a964-1bd03a17****</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        /// <summary>
        /// <para>The ingress application. The application is in the EDAS:{application ID} format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDAS:dd2690a7-3fe4-4975-9a4c-5a60ffd6****</para>
        /// </summary>
        [NameInMap("EntryApp")]
        [Validation(Required=false)]
        public string EntryApp { get; set; }

        /// <summary>
        /// <para>The ID of the lane group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The name of the lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-swimlanegroup</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
