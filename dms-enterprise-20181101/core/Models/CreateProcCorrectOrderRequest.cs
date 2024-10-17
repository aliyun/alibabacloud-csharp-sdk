// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateProcCorrectOrderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>order_attachment.txt</para>
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateProcCorrectOrderRequestParam Param { get; set; }
        public class CreateProcCorrectOrderRequestParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateProcCorrectOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateProcCorrectOrderRequestParamDbItemList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19721978</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            [NameInMap("ExecMode")]
            [Validation(Required=false)]
            public string ExecMode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELIMITER ///
            /// CREATE PROCEDURE GetAllProducts()
            /// BEGIN
            /// SELECT *  FROM base_user;
            /// END ///</para>
            /// </summary>
            [NameInMap("ExecSQL")]
            [Validation(Required=false)]
            public string ExecSQL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_rollback.sql</para>
            /// </summary>
            [NameInMap("RollbackAttachmentName")]
            [Validation(Required=false)]
            public string RollbackAttachmentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("RollbackSqlType")]
            [Validation(Required=false)]
            public string RollbackSqlType { get; set; }

        }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
