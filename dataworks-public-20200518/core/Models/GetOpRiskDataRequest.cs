// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpRiskDataRequest : TeaModel {
        /// <summary>
        /// The date on which the access records were queried. Specify the value in the yyyyMMdd format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// The parameters that you can specify to query the access records. Valid values:
        /// 
        /// *   dbType: the data type
        /// *   instanceName: the name of the instance
        /// *   databaseName: the name of the database
        /// *   projectName: the name of the workspace
        /// *   clusterName: the name of the cluster
        /// 
        /// The following example shows the parameters configured to query the access records of the sensitive data in the abc database of the ABC Hologres instance:
        /// 
        /// {"dbType":"hologres","instanceName":"ABC","databaseName":"abc"}
        /// 
        /// You must specify the parameters based on the compute engine that you use in your business.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of the page to return. Minimum value: 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 1000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The method that you use to identify risks.
        /// 
        /// *   You can manually identify risks.
        /// *   You can also use a risk rule to identify risks. You can go to the DataWorks console to obtain the name of the risk rule on the Custom Identification Rules page of Data Security Guard.
        /// </summary>
        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public string RiskType { get; set; }

    }

}
