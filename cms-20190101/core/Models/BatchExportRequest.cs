// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class BatchExportRequest : TeaModel {
        /// <summary>
        /// When you call this operation to export data, you must specify the `Cursor` parameter. You can obtain the value of the `Cursor` parameter by using one of the following methods:
        /// 
        /// *   When you call this operation for the first time, you must call the Cursor operation to obtain the `Cursor` value. For more information, see [Cursor](~~2330730~~).
        /// *   When you call this operation again, you can obtain the `Cursor` value from the returned data of the last call.
        /// </summary>
        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// The maximum number of data entries that can be returned in each response.
        /// 
        /// Valid values: 1 to 10000.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// The statistical methods used to customize the returned data. By default, the measurements based on all statistical methods are returned.
        /// 
        /// For example, the `cpu_idle` metric of ECS (`acs_ecs_dashboard`) has three statistical methods: `Average`, `Maximum`, and `Minimum`. If you want to return only the measurements based on the `Average` and `Maximum` statistical methods, set this parameter to `["Average", "Maximum"]`.
        /// 
        /// The statistical methods of metrics are displayed in the `Statistics` column on the Metrics page of each cloud service. For more information, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("Measurements")]
        [Validation(Required=false)]
        public List<string> Measurements { get; set; }

        /// <summary>
        /// The metric that is used to monitor the cloud service.
        /// 
        /// For more information about the metrics of cloud services, see [Appendix 1: Metrics](~~163515~~).
        /// 
        /// >  The value of this parameter must be the same as the value of the request parameter `Metric` in the Cursor operation.
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For more information about the namespaces of cloud services, see [Appendix 1: Metrics](~~163515~~).
        /// 
        /// >  The value of this parameter must be the same as the value of the request parameter `Namespace` in the Cursor operation.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
