// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DLFunctionInput : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>com.example.hive.MyCustomUDF</para>
        /// </summary>
        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1731586286</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public long? CreatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my_funciton</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JAVA</para>
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26****</para>
        /// </summary>
        [NameInMap("ModifierId")]
        [Validation(Required=false)]
        public long? ModifierId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("OwnerName")]
        [Validation(Required=false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("ResourceUris")]
        [Validation(Required=false)]
        public List<DLResourceUri> ResourceUris { get; set; }

    }

}
