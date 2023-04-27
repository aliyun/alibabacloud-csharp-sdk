// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskOutputRequest : TeaModel {
        /// <summary>
        /// ## Single-instance SQL assignment
        /// 
        /// - Example of NodeOutput:```
        /// Variable extraction settings
        ///              
        ///                 "row":0, // Rows. -1 indicates all rows.
        ///                 "column":-1, // Columns. -1 indicates all columns.
        ///                  
        ///                 Delimiter
        ///                 If you select all rows or columns, you must specify a connector. The returned value of the variable is a string.
        ///                  
        ///                   
        ///              
        ///              
        ///               
        ///             "variableName":"var", // Variable name
        ///             "description":"For demo" // Variable description
        /// ```
        /// 
        /// 
        /// ## Script code /ECS remote command
        /// 
        /// - Example of NodeOutput:```
        /// "extractMethod":"json", // JSON
        ///             "variableName":"var", // Variable name
        ///             "description":"demo desc" // Variable description
        /// ```
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Updates the output variables for a specified task node.
        /// </summary>
        [NameInMap("NodeOutput")]
        [Validation(Required=false)]
        public string NodeOutput { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **UpdateTaskOutput**.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
