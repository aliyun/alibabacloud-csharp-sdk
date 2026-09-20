// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableModelInfoRequest : TeaModel {
        /// <summary>
        /// <para>The first-level topic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("FirstLevelThemeId")]
        [Validation(Required=false)]
        public long? FirstLevelThemeId { get; set; }

        /// <summary>
        /// <para>The level ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("LevelId")]
        [Validation(Required=false)]
        public long? LevelId { get; set; }

        /// <summary>
        /// <para>The level type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: logical level.</description></item>
        /// <item><description>2: physical level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LevelType")]
        [Validation(Required=false)]
        public int? LevelType { get; set; }

        /// <summary>
        /// <para>The second-level topic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("SecondLevelThemeId")]
        [Validation(Required=false)]
        public long? SecondLevelThemeId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the table, in the format of odps.{projectName}.{tableName}.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.test.table1</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
