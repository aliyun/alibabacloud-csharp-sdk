// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpRiskDataRequest : TeaModel {
        /// <summary>
        /// The date on which access records were generated. Specify the value in the yyyyMMdd format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// The parameters that you can configure to query the access records. Valid values:
        /// 
        /// *   dbType
        /// *   instanceName
        /// *   databaseName
        /// *   projectName
        /// *   clusterName
        /// 
        /// The following example shows the parameters configured to query the access records of the sensitive data in the abc database of the Hologres instance ABC: [ {"dbType":"hologres","instanceName":"ABC","databaseName":"abc"} ]
        /// 
        /// You must configure the parameters based on the compute engine that you use in your business.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The page number. Pages start from 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 1000.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The method that you use to identify risks. Valid values:
        /// 
        /// *   You can manually identify risks.
        /// *   You can also use a sensitive data identification rule to identify risks. You can log on to the DataWorks console and go to the Risk Identification Rules page in Data Security Guard to obtain the name of the rule.
        /// </summary>
        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public string RiskType { get; set; }

    }

}
