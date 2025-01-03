// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkItemAllFieldsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e8bxxxxxxxxxxxxxxxx23</para>
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfexxxxxf4fee18xxxxx36</para>
        /// </summary>
        [NameInMap("workitemTypeIdentifier")]
        [Validation(Required=false)]
        public string WorkitemTypeIdentifier { get; set; }

    }

}
