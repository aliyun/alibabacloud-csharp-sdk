// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// 关联算法，人群来源为算法。
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// 手机号列名，人群来源为CSV文件，MaxCompute，并且包含手机号时需指定。
        /// </summary>
        [NameInMap("Column")]
        [Validation(Required=false)]
        public string Column { get; set; }

        /// <summary>
        /// 过滤条件，人群来源为MaxCompute时可指定。
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// 预测任务Id，人群来源为算法。
        /// </summary>
        [NameInMap("InferenceJobId")]
        [Validation(Required=false)]
        public string InferenceJobId { get; set; }

        /// <summary>
        /// 人群名称。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 是否包含手机号，包含手机号的人群可用于触达计划。
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public bool? PhoneNumber { get; set; }

        /// <summary>
        /// MaxCompute(ODPS)项目名，人群来源为MaxCompute时需指定。
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// 人群备注。
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 人群来源。
        /// - 0: 文本，每行一个手机号，最多100个。
        /// - 1: 文本文件，每行一个手机号，可通过控制台上传或指定自定义OSS地址，指定自定义OSS地址前需确保已在控制台完成一键授权。
        /// - 2: CSV文件，需指定手机号列名，可通过控制台上传或指定自定义OSS地址，指定自定义OSS地址前需确保已在控制台完成一键授权。
        /// - 3: MaxCompute(ODPS)表，需指定手机号列名。
        /// - 4: 算法。
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public int? Source { get; set; }

        /// <summary>
        /// MaxCompute(ODPS)表名，人群来源为MaxCompute时需指定。
        /// </summary>
        [NameInMap("Table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// 文本，人群来源为文本时需指定。
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// 文件地址，人群来源为文本文件，CSV文件，MaxCompute时需指定。
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
