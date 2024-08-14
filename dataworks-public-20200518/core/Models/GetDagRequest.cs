// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDagRequest : TeaModel {
        /// <summary>
        /// The ID of the DAG. You can use one of the following method to obtain the ID:
        /// 
        /// *   Call the [RunCycleDagNodes](https://help.aliyun.com/document_detail/2780209.html) operation and obtain the value of the **Data** response parameter.
        /// *   Call the [RunSmokeTest](https://help.aliyun.com/document_detail/2780210.html) operation and obtain the value of the **Data** response parameter.
        /// *   Call the [RunManualDagNodes](https://help.aliyun.com/document_detail/2780218.html) operation and obtain the value of the **DagId** response parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The environment of the workspace. Valid values: PROD and DEV.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
