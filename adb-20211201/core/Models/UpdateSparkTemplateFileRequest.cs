// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class UpdateSparkTemplateFileRequest : TeaModel {
        /// <summary>
        /// The template data to be updated.
        /// 
        /// >  If you do not specify this parameter, the application template is not updated. For information about how to configure a Spark application template, see [Configure a Spark application](~~452402~~).
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The application template ID.
        /// 
        /// >  You can call the [GetSparkTemplateFullTree](~~456205~~) operation to query the application template ID.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the job resource group.
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
