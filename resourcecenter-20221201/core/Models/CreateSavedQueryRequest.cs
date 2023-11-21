/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class CreateSavedQueryRequest : TeaModel {
        /// <summary>
        /// The description of the template.
        /// 
        /// The description must be 1 to 256 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The query statement in the template.
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// The name of the template.
        /// 
        /// *   The name must be 1 to 64 characters in length.
        /// *   The name can contain letters, digits, underscores (\_), and hyphens (-).
        /// *   The name must be unique.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
