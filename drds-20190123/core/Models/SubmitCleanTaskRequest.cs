// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitCleanTaskRequest : TeaModel {
        /// <summary>
        /// The name of the database that is scaled out.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The scale-out type. Valid values:
        /// 
        /// *   smooth_expand: smooth scale-out
        /// *   hot_expand: hot-spot scale-out
        /// </summary>
        [NameInMap("ExpandType")]
        [Validation(Required=false)]
        public string ExpandType { get; set; }

        /// <summary>
        /// The job ID of the scale-out task. The value of this parameter is the same as that of the ParentJobId parameter.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The ID of the scale-out task. This parameter is returned if you send a request for the smooth scale-out task.
        /// </summary>
        [NameInMap("ParentJobId")]
        [Validation(Required=false)]
        public string ParentJobId { get; set; }

    }

}
