/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// 算法名称
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// 手机号列名
        /// </summary>
        [NameInMap("Column")]
        [Validation(Required=false)]
        public string Column { get; set; }

        /// <summary>
        /// ODPS过滤语句
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// 推理任务
        /// </summary>
        [NameInMap("InferenceJob")]
        [Validation(Required=false)]
        public string InferenceJob { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// ODPS项目名
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 人群来源
        /// - 0: Text，每行一个手机号
        /// - 1: 无header的csv文件，每行一个手机号
        /// - 2: 带header的csv文件，需指定手机号列名
        /// - 3: Odps，需指定手机号列名
        /// - 4: Algorithm，由算法预测生成
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public int? Source { get; set; }

        /// <summary>
        /// ODPS表名
        /// </summary>
        [NameInMap("Table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// 文本
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
