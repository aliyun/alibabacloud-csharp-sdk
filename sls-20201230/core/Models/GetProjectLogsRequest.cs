// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetProjectLogsRequest : TeaModel {
        /// <summary>
        /// 是否使用SQL独享版。更多信息，请参见开启SQL独享版。
        /// 
        /// true：使用SQL独享版。
        /// false（默认值）：使用SQL普通版。
        /// 除通过powerSql参数配置SQL独享版外，您还可以使用query参数。
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// 标准SQL语句。例如日志库名称为nginx-moni，查询时间区间在2022-03-01 10:41:40到2022-03-01 10:56:40之间的访问数量。
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
