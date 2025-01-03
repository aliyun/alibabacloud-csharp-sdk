// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateWorkitemFieldRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("updateWorkitemPropertyRequest")]
        [Validation(Required=false)]
        public List<UpdateWorkitemFieldRequestUpdateWorkitemPropertyRequest> UpdateWorkitemPropertyRequest { get; set; }
        public class UpdateWorkitemFieldRequestUpdateWorkitemPropertyRequest : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9144ef6b72d8exxxxx9e61a4d0</para>
        /// </summary>
        [NameInMap("workitemIdentifier")]
        [Validation(Required=false)]
        public string WorkitemIdentifier { get; set; }

    }

}
